
string quest = await DownloadQuest();

Console.WriteLine($"New Quest: {quest}");

static async Task<string> DownloadQuest()
{
    Console.WriteLine("Downloading quest data...");

    await Task.Delay(3000);

    return "Defeat the Dragon";
}