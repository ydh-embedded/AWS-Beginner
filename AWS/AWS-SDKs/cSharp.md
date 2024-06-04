# SDK in cSharp

```cs
using System;
using System.Threading.Tasks;
using Amazon.Polly;
using Amazon.Polly.Model;

namespace PollyExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an Amazon Polly client
            var pollyClient = new AmazonPollyClient();

            // Set up the synthesize speech request
            var synthesizeSpeechRequest = new SynthesizeSpeechRequest
            {
                OutputFormat = OutputFormat.Mp3,
                SampleRate = SampleRate.SixteenKilohertz,
                Text = "Hello, world!",
                TextType = TextType.Text,
                VoiceId = VoiceId.Joanna
            };

            // Synthesize the speech
            var synthesizeSpeechResponse = await pollyClient.SynthesizeSpeechAsync(synthesizeSpeechRequest);

            // Save the synthesized speech to a file
            using (var fileStream = System.IO.File.OpenWrite("speech.mp3"))
            {
                await synthesizeSpeechResponse.AudioStream.CopyToAsync(fileStream);
            }

            Console.WriteLine("Speech synthesized and saved to speech.mp3.");
        }
    }
}

```
## Definition
This script initializes the AWS SDK with your AWS Region and Identity Pool ID. When the speakText function is called, it creates a new Amazon Polly service object and uses the getSynthesizeSpeechUrl method to get a presigned URL for the synthesized speech audio stream. The URL is then used to play the synthesized speech in the browser.

To use this script, replace 'REGION' and 'IDENTITY_POOL_ID' with your actual AWS Region and Identity Pool ID. Also, make sure to include the AWS SDK for JavaScript library in your HTML file by adding the following line:

````html

<script src="https://sdk.amazonaws.com/js/aws-sdk-SDK_VERSION_NUMBER.min.js"></script>
````
