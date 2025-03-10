﻿using Microsoft.AspNetCore.Components.WebView;
using Microsoft.Maui.Controls;

namespace MauiBlazorPermissionsExample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        _blazorWebView.BlazorWebViewInitializing += BlazorWebViewInitializing;
        _blazorWebView.BlazorWebViewInitialized += BlazorWebViewInitialized;
    }

    partial void BlazorWebViewInitializing(object? sender, BlazorWebViewInitializingEventArgs e);
    partial void BlazorWebViewInitialized(object? sender, BlazorWebViewInitializedEventArgs e);
}
