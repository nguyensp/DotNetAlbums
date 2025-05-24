using System.Text.Json.Serialization;

namespace MostPlayedAlbums.Models
{
    public class AlbumResponse
    {
        [JsonPropertyName("feed")]
        public Feed Feed { get; set; }
    }

    public class Feed
    {
        [JsonPropertyName("results")]
        public List<Album> Results { get; set; } = new List<Album>();
    }

    public class Album
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string AlbumName { get; set; }

        [JsonPropertyName("artistName")]
        public string AlbumArtist { get; set; }

        [JsonPropertyName("artworkUrl100")]
        public string AlbumCover { get; set; }

        [JsonPropertyName("artistId")]
        public string ArtistId { get; set; }

        [JsonPropertyName("artistUrl")]
        public string ArtistUrl { get; set; }

        [JsonPropertyName("contentAdvisoryRating")]
        public string ContentAdvisoryRating { get; set; }

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}