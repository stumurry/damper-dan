# damper-dan

To clone the respository:

`git clone https://github.com/stumurry/damper-dan`



# Damper Dan Client (Angular)

A customer facing portal they can view devices where they can purchase or upgrade their services.

Client interface is a .NET Core application written in C#.  It contains EntityFramework, Angular TypeScript, and uses Mysql.  Files are best viewed using Visual Studio for Mac or PC.  This application was developed and tested on a MAC.  

```

```

# Damper Dan Inspector (React Native)

# Caution for MAC users

`React Native` requires some adjustments before using.

Execute these commands before `npm start`
```
sudo sysctl -w kern.maxfiles=5242880
sudo sysctl -w kern.maxfilesperproc=524288
```

An app that aids the inspector in testing client's devices 

```
npm i -g create-react-native-app

create-react-native-app damper-dan-inspector

cd damper-dan-inspector

npm start

```


