// See https://aka.ms/new-console-template for more information

using Proxy;

YouTubeService youTubeService = new YouTubeService();



ProxyYouTubeService proxyYouTubeService = new ProxyYouTubeService(youTubeService);
proxyYouTubeService.GetVideo(10);
proxyYouTubeService.GetVideo(10);