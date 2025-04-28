using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using APPLIVE.ENTITIES;

namespace APPLIVES.APPLICATION
{
    public class APPLIVE_IptvServices : APPLIVE_IIptvService
    {
        private static List<APPI_CHANELS>? channelsCache;
        private static List<APPLIVE_Stream>? streamsCache;
        private static List<APPLIVE_Category>? categoriesCache;
        private static List<APPLIVE_Country>? countriesCache;


        private static readonly HttpClient http = new();
        public async Task<List<APPI_CHANELS>> GetChannelsAsync(string category = null, string country = null, string search = null)
        {
            

            //return result;
            if (categoriesCache == null || countriesCache == null || channelsCache == null || streamsCache == null)
                await LoadDataAsync();  // Cargar datos si no están en caché

            // Asociar streams (solo si aún no se ha hecho)
            foreach (var ch in channelsCache)
            {
                if (string.IsNullOrEmpty(ch.StreamUrl)) // Evita sobreescribir si ya está asignado
                {
                    var stream = streamsCache?.FirstOrDefault(s => s.Channel == ch.Id && !string.IsNullOrEmpty(s.Url));
                    if (stream != null)
                    {
                        ch.StreamUrl = stream.Url;
                    }
                }
            }

            // Filtrar solo los que tengan stream
            var result = channelsCache.Where(c => !string.IsNullOrEmpty(c.StreamUrl)).ToList();

            // Filtrar por categoría
            if (!string.IsNullOrWhiteSpace(category))
                result = result.Where(c => c.Categories?.Contains(category, StringComparer.OrdinalIgnoreCase) == true).ToList();

            // Filtrar por país
            if (!string.IsNullOrWhiteSpace(country))
                result = result.Where(c => c.Country?.Equals(country, StringComparison.OrdinalIgnoreCase) == true).ToList();

            // Filtrar por nombre
            if (!string.IsNullOrWhiteSpace(search))
                result = result.Where(c => c.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            return result;
        }
        private async Task LoadDataAsync()
        {
            // Cargar los datos de los canales, streams, categorías y países
            var channelsTask = http.GetFromJsonAsync<List<APPI_CHANELS>>("https://iptv-org.github.io/api/channels.json");
            var streamsTask = http.GetFromJsonAsync<List<APPLIVE_Stream>>("https://iptv-org.github.io/api/streams.json");
            var categoriesTask = http.GetFromJsonAsync<List<APPLIVE_Category>>("https://iptv-org.github.io/api/categories.json");
            var countriesTask = http.GetFromJsonAsync<List<APPLIVE_Country>>("https://iptv-org.github.io/api/countries.json");



            // Esperar que todas las peticiones se completen
            await Task.WhenAll(channelsTask, streamsTask, categoriesTask, countriesTask);

            // Asignar los datos a las variables estáticas
            channelsCache = await channelsTask;
            streamsCache = await streamsTask;
            categoriesCache = await categoriesTask;
            countriesCache = await countriesTask;

            // Emparejar streams con canales si es necesario
            foreach (var ch in channelsCache)
            {
                ch.Categories ??= new List<string>();
                ch.Logo ??= "";
            }
            // Asociar cada canal con su primer stream disponible
            foreach (var ch in channelsCache)
            {
                var stream = streamsCache?.FirstOrDefault(s => s.Channel == ch.Id && !string.IsNullOrEmpty(s.Url));
                if (stream != null)
                {
                    ch.StreamUrl = stream.Url;
                }
            }

            


        }
        // Método para obtener categorías desde la caché
        public List<APPLIVE_Category>? GetCategories()
        {
            return categoriesCache;
        }
        public List<APPLIVE_Country>? GetCountries()
        {
            return countriesCache;
        }



    }
}
