<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsUpdates.aspx.cs" Inherits="newsupdate.NewsUpdates" %>

<!DOCTYPE html>
<html>
<head>
    <title>News Updates</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 20px;
        }
        .container {
            max-width: 800px;
            margin: 0 auto;
            background-color: #fff;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            padding: 20px;
        }
        .header-image {
            display: block;
            margin: 0 auto;
            width: 200px;
            height: auto;
            margin-bottom: 20px;
        }
        h1 {
            font-size: 24px;
            margin-top: 0;
        }
        .news-item {
            margin-bottom: 20px;
            border-bottom: 1px solid #ddd;
            padding-bottom: 20px;
        }
        .news-title {
            font-weight: bold;
            font-size: 18px;
            margin-bottom: 5px;
        }
        .news-date {
            color: #888;
            margin-bottom: 10px;
        }
        .news-content {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>News Updates</h1>

<%--        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Suncor_Energy.svg/1920px-Suncor_Energy.svg.png" alt="Logo" class="header-image" />--%>
        <img src="" alt="Logo" class="header-image" />
        <% foreach (var newsItem in NewsItems) { %>
            <div class="news-item">
                <div class="news-title"><%= newsItem.Title %></div>
                <div class="news-date"><%= newsItem.Date.ToString() %></div>
                <div class="news-content"><%= newsItem.Content %></div>
            </div>
        <% } %>
    </div>
</body>
</html>
