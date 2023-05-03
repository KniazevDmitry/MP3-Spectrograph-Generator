using NAudio.Wave;

namespace MP3_Spectrograph_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the MP3 file: ");
            string filePath = Console.ReadLine();

            int bitrate = GetBitRate(filePath);
            Console.WriteLine($"The file's bitrate is {bitrate / 1000} kbps");
        }

        //using NAudio Mp3FileReader to read the frame's bitrate
        static int GetBitRate(string filePath)
        {
            using Mp3FileReader reader = new Mp3FileReader(filePath);
            Mp3Frame mp3FileFrame = reader.ReadNextFrame();

            return mp3FileFrame.BitRate;
        }
    }


}