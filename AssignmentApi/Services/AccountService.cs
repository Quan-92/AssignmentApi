using AssignmentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace AssignmentApi.Services
{
    public class AccountService
    {
        private static string ApiBaseUrl = "https://music-i-like.herokuapp.com";
        private static string ApiLoginPath = "/api/v1/accounts/authentication";
        private static string ApiRegisterPath = "/api/v1/accounts";
        private static string ApiDataType = "application/json";

        public async Task<bool> Login(Account account)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApiBaseUrl);
                    var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                    var contentToSend = new StringContent(jsonContent, Encoding.UTF8, ApiDataType);
                    var result = await httpClient.PostAsync(ApiLoginPath, contentToSend);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Error!";
                dialog.Content = $"{e.Message}";
                dialog.CloseButtonText = "OK";
                await dialog.ShowAsync();
                return false;
            }
        }
        public async Task<bool> Register(Account account)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(ApiBaseUrl);
                    var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                    var contentToSend = new StringContent(jsonContent, Encoding.UTF8, ApiDataType);
                    var result = await httpClient.PostAsync(ApiRegisterPath, contentToSend);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Error!";
                dialog.Content = $"{e.Message}";
                dialog.CloseButtonText = "OK";
                await dialog.ShowAsync();
                return false;
            }
        }
    }
}
