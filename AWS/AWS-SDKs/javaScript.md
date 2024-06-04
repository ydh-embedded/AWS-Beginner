# SDK in java Script

```js

<script type="text/javascript">
    // Initialize the Amazon Cognito credentials provider
    AWS.config.region = 'REGION';
    AWS.config.credentials = new AWS.CognitoIdentityCredentials({IdentityPoolId: 'IDENTITY_POOL_ID'});

    // Function invoked by button click
    function speakText() {
        // Create the JSON parameters for getSynthesizeSpeechUrl
        var speechParams = {
            OutputFormat: "mp3",
            SampleRate: "16000",
            Text: "",
            TextType: "text",
            VoiceId: "Matthew"
        };
        speechParams.Text = document.getElementById("textEntry").value;

        // Create a new Amazon Polly service object
        var polly = new AWS.Polly();

        // Use the getSynthesizeSpeechUrl method to get a presigned URL for the synthesized speech audio stream
        polly.getSynthesizeSpeechUrl(speechParams, function(err, data) {
            if (err) {
                console.log(err.message);
            } else {
                // Set the audio source element's src attribute to the presigned URL
                document.getElementById('audioSource').src = data.SynthesizeSpeechUrl;
                document.getElementById('audioPlayback').load();
                document.getElementById('result').innerHTML = "Speech ready to play.";
            }
        });
    }
</script>
```


This script initializes the AWS SDK with your AWS Region and Identity Pool ID. When the speakText function is called, it creates a new Amazon Polly service object and uses the getSynthesizeSpeechUrl method to get a presigned URL for the synthesized speech audio stream. The URL is then used to play the synthesized speech in the browser.

To use this script, replace 'REGION' and 'IDENTITY_POOL_ID' with your actual AWS Region and Identity Pool ID. Also, make sure to include the AWS SDK for JavaScript library in your HTML file by adding the following line:

```html

<script src="https://sdk.amazonaws.com/js/aws-sdk-SDK_VERSION_NUMBER.min.js"></script>

```

Replace SDK_VERSION_NUMBER with the actual version number of the AWS SDK for JavaScript library you want to use.

Note: This script assumes that you have an input element with the ID textEntry, and audio elements with the IDs audioSource and audioPlayback in your HTML file. Make sure to include these elements in your HTML file for the script to work correctly.