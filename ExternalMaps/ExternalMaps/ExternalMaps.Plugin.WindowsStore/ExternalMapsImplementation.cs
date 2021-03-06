using ExternalMaps.Plugin.Abstractions;
using System;
using System.Globalization;


namespace ExternalMaps.Plugin
{
  /// <summary>
  /// Implementation for ExternalMaps
  /// </summary>
  public class ExternalMapsImplementation : IExternalMaps
  {

    /// <summary>
    /// Navigate to specific latitude and longitude.
    /// </summary>
    /// <param name="name">Label to display</param>
    /// <param name="latitude">Lat</param>
    /// <param name="longitude">Long</param>
    /// <param name="navigationType">Type of navigation</param>
    public void NavigateTo(string name, double latitude, double longitude, NavigationType navigationType = NavigationType.Default)
    {

      if (string.IsNullOrWhiteSpace(name))
        name = string.Empty;


      Windows.System.Launcher.LaunchUriAsync(new Uri(string.Format("bingmaps:?collection=point.{0}_{1}_{2}", latitude.ToString(CultureInfo.InvariantCulture), longitude.ToString(CultureInfo.InvariantCulture), name)));
    }
    /// <summary>
    /// Navigate to an address
    /// </summary>
    /// <param name="name">Label to display</param>
    /// <param name="street">Street</param>
    /// <param name="city">City</param>
    /// <param name="state">Sate</param>
    /// <param name="zip">Zip</param>
    /// <param name="country">Country</param>
    /// <param name="countryCode">Country Code if applicable</param>
    /// <param name="navigationType">Navigation type</param>
    public void NavigateTo(string name, string street, string city, string state, string zip, string country, string countryCode, NavigationType navigationType = NavigationType.Default)
    {
      if (string.IsNullOrWhiteSpace(name))
        name = string.Empty;

      if (string.IsNullOrWhiteSpace(street))
        street = string.Empty;

      if (string.IsNullOrWhiteSpace(city))
        city = string.Empty;

      if (string.IsNullOrWhiteSpace(state))
        state = string.Empty;

      if (string.IsNullOrWhiteSpace(zip))
        zip = string.Empty;

      if (string.IsNullOrWhiteSpace(country))
        country = string.Empty;

      Windows.System.Launcher.LaunchUriAsync(new Uri(string.Format("bingmaps:?where={0}%20{1}%20{2}%20{3}%20{4}", street, city, state, zip, country)));
    }
  }
}