using System;
using System.Collections.Generic;
using System.Text;

namespace TinderSharp.Models.User
{

    public partial class RecommendedMatches
    {
        public long Status { get; set; }
        public List<RecommendedMatch> Results { get; set; }
    }
    public partial class RecommendedMatch
    {
        public bool group_matched { get; set; }
        public long distance_mi { get; set; }
        public string content_hash { get; set; }
        public List<object> common_friends { get; set; }
        public List<object> common_likes { get; set; }
        public long common_friend_count { get; set; }
        public long common_like_count { get; set; }
        public long connection_count { get; set; }
        public string _id { get; set; }
        public string bio { get; set; }
        public DateTimeOffset birth_date { get; set; }
        public string name { get; set; }
        public DateTimeOffset ping_time { get; set; }
        public List<ResultPhoto> photos { get; set; }
        public Instagram instagram { get; set; }
        public List<MatchJob> jobs { get; set; }
        public List<MatchSchool> schools { get; set; }
        public Teaser teaser { get; set; }
        public List<Teaser> teasers { get; set; }
        public long gender { get; set; }
        //public BirthDateInfo birth_date_info { get; set; }
        public long s_number { get; set; }
        public List<SpotifyTopArtist> SpotifyTopArtists { get; set; }
        public Track SpotifyThemeTrack { get; set; }
        public bool? IsTraveling { get; set; }
    }

    public partial class Instagram
    {
        public DateTimeOffset last_fetch_time { get; set; }
        public bool completed_initial_fetch { get; set; }
        public List<InstagramPhoto> photos { get; set; }
        public long media_count { get; set; }
        public Uri profile_picture { get; set; }
        public string username { get; set; }
    }

    public partial class InstagramPhoto
    {
        public Uri image { get; set; }
        public Uri thumbnail { get; set; }
        public long ts { get; set; }
        public Uri link { get; set; }
    }

    public partial class MatchJob
    {
        public School title { get; set; }
    }

    public partial class MatchSchool
    {
        public string name { get; set; }
    }

    public partial class ResultPhoto
    {
        public Guid id { get; set; }
        public CropInfo crop_info { get; set; }
        public Uri url { get; set; }
        public List<ProcessedFile> processedFiles { get; set; }
        public string fileName { get; set; }
        public string extension { get; set; }
        public bool? main { get; set; }
        public List<ProcessedFile> processedVideos { get; set; }
    }



    public partial class Track
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Uri PreviewUrl { get; set; }
        public string Uri { get; set; }
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
    }

    public partial class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ProcessedFile> Images { get; set; }
    }

    public partial class Artist
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public partial class SpotifyTopArtist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Track TopTrack { get; set; }
        public bool Selected { get; set; }
    }

    public partial class Teaser
    {
        public string String { get; set; }
        public string Type { get; set; }
    }

    //public enum BirthDateInfo { FuzzyBirthdateActiveNotDisplayingRealBirthDate };


    ////public enum Username { Tinder };

    //public enum Extension { Jpg };

    //public enum TypeEnum { artists, instagram, job, school, position, jobPosition };
}
