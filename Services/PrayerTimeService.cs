// namespace MudBlazorMiniApp.Services;
// public class PrayerTimeService
// {
//     private List<PrayerTime> PrayerTimes = new();
//     private bool IsLoading = true;
//     private string? currentTime;
//     protected override async Task OnInitializedAsync()
//     {
//         try
//         {
//             var response = await Http.GetFromJsonAsync<PrayerApiResponse>("https://api.aladhan.com/v1/timings?latitude=41.2995&longitude=69.2401&method=2");
//             if (response?.Data?.Timings != null)
//             {
//                 PrayerTimes = response.Data.Timings.Select(t => new PrayerTime
//                 {
//                     Prayer = t.Key,
//                     Time = t.Value
//                 }).ToList();
//             }
//         }
//         catch (Exception ex)
//         {
//             Snackbar.Add($"Namoz vaqtlarini olishda xatolik yuz berdi: {ex.Message}", Severity.Error);
//         }
//         finally
//         {
//             IsLoading = false;
//         }

//         var timer = new System.Threading.Timer(_ =>
//         {
//             currentTime = DateTime.Now.ToString("HH:mm:ss");
//             StateHasChanged();
//         }, null, 0, 1000);
//     }

//     private class PrayerApiResponse
//     {
//         public PrayerData? Data { get; set; }
//     }

//     private class PrayerData
//     {
//         public Dictionary<string, string>? Timings { get; set; }
//     }

//     private class PrayerTime
//     {
//         public string? Prayer { get; set; }
//         public string? Time { get; set; }
//     }
// }
