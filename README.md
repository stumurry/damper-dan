# damper-dan

# Caution for MAC users

Execute these commands before `npm start`
```
sudo sysctl -w kern.maxfiles=5242880
sudo sysctl -w kern.maxfilesperproc=524288
```


# Damper Dan Inspector (React Native)

An app that aids the inspector in testing client's devices 

```
npm i -g create-react-native-app

create-react-native-app damper-dan-inspector

cd damper-dan-inspector

npm start

```

# Damper Dan Client (React)

A customer facing portal they can view devices where they can purchase or upgrade their services.

```
npm install -g create-react-app yarn

create-react-app damper-dan-client

cd damper-dan-client

npm start

```
