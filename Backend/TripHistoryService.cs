using System;
using System.IO;

namespace Metro_App.Backend
{
    public static class TripHistoryService
    {
        private const string HistoryFolderName = "Metro App Travel History";
        private const string TripNumberFileName = "TripNumber.txt";
        private const string HistoryFileName = "Travel History.txt";
        private const string ReceiptFileName = "Receipt.txt";

        private static string HistoryFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, HistoryFolderName);
        public static string ReceiptFilePath => Path.Combine(HistoryFolder, ReceiptFileName);

        public static string SaveTrip(string startStation, string endStation, int distance)
        {
            Directory.CreateDirectory(HistoryFolder);

            int tripNumber = GetNextTripNumber();
            string tripInfo =
                $"Trip {tripNumber}:{Environment.NewLine}" +
                $"Starting Station: {startStation}{Environment.NewLine}" +
                $"Final Station: {endStation}{Environment.NewLine}" +
                $"Distance: {distance} km{Environment.NewLine}" +
                $"Time: {DateTime.Now:t}{Environment.NewLine}" +
                $"Date: {DateTime.Now:dddd, d MMMM yyyy}{Environment.NewLine}{Environment.NewLine}";

            File.AppendAllText(Path.Combine(HistoryFolder, HistoryFileName), tripInfo);
            File.WriteAllText(ReceiptFilePath, tripInfo);

            return tripInfo;
        }

        public static string ReadLatestReceipt()
        {
            return File.Exists(ReceiptFilePath) ? File.ReadAllText(ReceiptFilePath) : string.Empty;
        }

        private static int GetNextTripNumber()
        {
            string tripNumberPath = Path.Combine(HistoryFolder, TripNumberFileName);

            int tripNumber = 0;
            if (File.Exists(tripNumberPath))
            {
                int.TryParse(File.ReadAllText(tripNumberPath), out tripNumber);
            }

            tripNumber++;
            File.WriteAllText(tripNumberPath, tripNumber.ToString());

            return tripNumber;
        }
    }
}
