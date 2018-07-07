# Damper Dan Test Suite

Create a `.secret.json` file:

```
{
    "Pubnub" : {
        "PublishKey" : "<YourPubnubPublishKey>",
        "SubscribeKey" : "<YourPubnubSubscribeKey>",
    }
}
```

` dotnet restore `

` dotnet test `

# AWS S3

`dotnet add package AWSSDK.S3 -v 3.3.18.6`

` dotnet restore `

# JSON

`dotnet add package Newtonsoft.Json`
