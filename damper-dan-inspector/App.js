import React, { Component } from 'react';
import { StyleSheet, Text, View, Button, Image, FlatList } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import t from 'tcomb-form-native';
import PubNub from 'pubnub';

const pubnub = new PubNub({
  subscribeKey: "sub-c-f8288e34-8ee4-11e8-8b6c-9a2ed1c29e11"
});

const counter = 0;
const imageSource = "";
const windSpeed = 0;
const temperature = 0;
const altitude = 0;
const humidity = 0;

pubnub.addListener({
  status: function (statusEvent) {
    if (statusEvent.category === "PNConnectedCategory") {
      console.log('connection open');
    } else if (statusEvent.category === "PNUnknownCategory") {
      var newState = {
        new: 'error'
      };
      pubnub.setState(
        {
          state: newState
        },
        function (status) {
          console.log(statusEvent.errorData.message)
        }
      );
    }
  },
  message: function (response) {
    if (counter <= 1) {
      imageSource += response.message.image;
      counter++;
    } else {
      imageSource = response.message.image;
      counter = 1;
    }
    windSpeed = response.message.windSpeed;
    temperature = response.message.temperature;
    altitude = response.message.altitude;
    humidity = response.message.humidity;
  }
});

pubnub.subscribe({
  channels: ['DamperDan'],
  callback: function (message) {
    console.log('hi');
  }
});


class LoginForm extends Component {
  render() {
    const Form = t.form.Form;

    const User = t.struct({
      email: t.String,
      password: t.String
    });

    const options = {
      fields: {
        email: {
          error: 'Without an email address how are you going to reset your password when you forget it?'
        },
        password: {
          error: 'Choose something you use on a dozen other sites or something you won\'t remember'
        }
      }
    };

    return (
      <View>
        <Form
          ref={c => this._form = c}
          type={User}
          options={options}
        />
      </View>
    );
  }
}

class Banner extends Component {
  render() {
    return (
      <View style={{ flex: .5, flexDirection: 'row', paddingTop: 15 }}>
        {/*<Image
          source={this.props.src}
          style={{ flex: .5 }}
        />*/}
        <Text style={{ fontWeight: '500' }}> LOREM IPSUM BUILDING 1</Text>
      </View>
    );
  }
}

class Buttons extends Component {
  render() {
    return (
      <View style={{ flex: .4, flexDirection: 'row', paddingTop: 20, paddingBottom: 15 }}>
        <Button
          title="Pass"
          color="#009600"
          onPress={pass}
        />
        <Text>      </Text>
        <Button
          title="Fail"
          color="#ff0000"
          onPress={fail}
        />
      </View>
    );
  }
}

class Tag extends Component {
  render() {
    return (
      <View style={{ flex: .2 }}>
        <Text style={{ fontSize: 20, fontWeight: '400' }}>MIS-CID-001-C</Text>
      </View>
    );
  }
}

class DamperInfo extends Component {
  render() {
    return (
      <View style={{ flex: 5, justifyContent: 'flex-start' }}>
        <Text>Temperature: {this.props.temperature} degrees F</Text>
        <Text>Wind Speed: {this.props.windSpeed} mph</Text>
        <Text>Humidity: {this.props.humidity}%</Text>
        <Text>Altitude: {this.props.altitude} feet</Text>
        <Text>Location:</Text>
        <Text>1 FOOT WEST OF ELEVATORS THRU NORTH WALL</Text>
        <Text>SOUTH EAST CORRIDOR ROOM 201</Text>
        <View style={{ paddingTop: 10 }}>
          <Button
            title="Cycle"
            onPress={cycleDamper}
            style={{ flex: 1 }}
          />
        </View>
        <Image
          source={this.props.src}
          style={{ flex: 1 }}
        />
      </View>
    );
  }
}


class LoginScreen extends Component {
  render() {
    return (
      <View style={styles.container}>
        <LoginForm />
        <Button
          title="Login"
          onPress={() => this.props.navigation.navigate('BuildingList')}
        />
      </View>
    );
  }
}

class BuildingScreen extends Component {
  constructor(props) {
    super(props);
    this.state = {};
  }

  componentDidMount() {
    return fetch('https://bqdor7fpq8.execute-api.us-east-1.amazonaws.com/prod/')
      .then((response) => response.json())
      .then((responseJson) => {

        this.setState({
          dataSource: responseJson,
        }, function () {

        });

      })
      .catch((error) => {
        console.error(error);
      });
  }

  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.select}>Select a Building</Text>
        <FlatList
          data={this.state.dataSource}
          renderItem={({ item }) => <View style={styles.button}><Button title={item.building_name} onPress={() => this.props.navigation.navigate('FloorList')} /><Text></Text></View>}
        />
      </View>
    );
  }
}

class FloorScreen extends Component {
  constructor(props) {
    super(props);
    this.state = {};
  }

  componentDidMount() {
    return fetch('https://d0l131z8pi.execute-api.us-east-1.amazonaws.com/prod?buildingid=27')
      .then((response) => response.json())
      .then((responseJson) => {

        this.setState({
          dataSource: responseJson,
        }, function () {

        });

      })
      .catch((error) => {
        console.error(error);
      });
  }

  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.select}>Select a Floor</Text>
        <FlatList
          data={this.state.dataSource}
          renderItem={({ item }) => <View style={styles.button} key={item.id}><Button title={item.floor_name} onPress={() => this.props.navigation.navigate('DamperList')} /><Text></Text></View>}
        />
      </View>
    );
  }
}

class DamperScreen extends Component {
  constructor(props) {
    super(props);
    this.state = {};
  }

  componentDidMount() {
    return fetch('https://fwolhnn6u7.execute-api.us-east-1.amazonaws.com/prod/?floorid=179')
      .then((response) => response.json())
      .then((responseJson) => {

        this.setState({
          dataSource: responseJson,
        }, function () {

        });

      })
      .catch((error) => {
        console.error(error);
      });
  }
  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.select}>Select a Damper to see details</Text>
        <FlatList
          data={this.state.dataSource}
          renderItem={({ item }) => <View style={styles.button}><Button title={item.alias_id + " - " + item.location} onPress={() => this.props.navigation.navigate('Details')} /><Text></Text></View>}
        />
      </View>
    );
  }
}

class DetailsScreen extends Component {
  constructor(props) {
    super(props);
    this.state = {
      image: imageSource,
      windSpeed: windSpeed,
      temperature: temperature,
      altitude: altitude,
      humidity: humidity
    };
    setInterval(() => {
      if (imageSource.length > 0) {
        this.setState({
          image: imageSource,
          windSpeed: windSpeed,
          temperature: temperature,
          altitude: altitude,
          humidity: humidity
        });
      }
    }, 5000);
  }

  render() {
    let imgSrc = 'data:image/jpeg;base64,' + imageSource;
    const samplePic = {
      uri: 'https://images.homedepot-static.com/productImages/96691c30-8dfb-49fd-92c9-845897f903c8/svn/speedi-collar-starting-collars-sc-12d-64_1000.jpg', width: 100, height: 100
    };
    const damperPic = {
      uri: imgSrc
    };

    return (
      <View style={styles.container}>
        <Banner
          src={samplePic}
        />
        <Text></Text>
        <Tag />
        <Buttons />
        <DamperInfo
          src={damperPic}
          windSpeed={this.state.windSpeed}
          temperature={this.state.temperature}
          altitude={this.state.altitude}
          humidity={this.state.humidity}
        />
        <Button
          title="Go back to Buildings Page"
          onPress={() => this.props.navigation.navigate('BuildingList')}
          style={{ flex: 1 }}
        />
      </View>
    );
  }
}

const RootStack = createStackNavigator({
  Login: LoginScreen,
  BuildingList: BuildingScreen,
  FloorList: FloorScreen,
  DamperList: DamperScreen,
  Details: DetailsScreen
},
  {
    initialRouteName: 'Login'
  }
);

export default class App extends React.Component {
  render() {
    return <RootStack />;
  }
}


const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fafafa',
    alignItems: 'center',
    justifyContent: 'center'
  },
  select: {
    margin: 5,
    fontWeight: '700',
    fontSize: 20
  },
  button: {
    paddingBottom: 10
  }
});

const pass = () => {
  alert('You have marked this damper as "Pass"');
}

const fail = () => {
  alert('You have marked this damper as "Fail"');
}

const cycleDamper = () => {
  alert('Damper has been cycled');
}

const handleSubmit = (email = null, password = null) => {
  const passw = /^[A-Za-z]\w{7,15}$/;
  const re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

  if (email.match(re)) {
    if (password.match(passw)) {
      alert('GREAT!');
    } else {
      alert('You must enter a password');
    }
  } else {
    alert('You must enter an email in the form of "example@example.com"');
  }
}