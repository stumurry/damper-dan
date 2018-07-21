import React, { Component } from 'react';
import { StyleSheet, Text, View, Button, Image, FlatList } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import t from 'tcomb-form-native';

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
      <View style={{ flex: .5, flexDirection: 'row' }}>
        <Image
          source={this.props.src}
          style={{ flex: .5 }}
        />
        <Text> LOREM IPSUM BUILDING 1</Text>
      </View>
    );
  }
}

class Buttons extends Component {
  render() {
    return (
      <View style={{ flex: .4, flexDirection: 'row' }}>
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
        <Text>MIS-CID-001-C</Text>
      </View>
    );
  }
}

class DamperInfo extends Component {
  render() {
    return (
      <View style={{ flex: 5, justifyContent: 'flex-start' }}>
        <Text>Temperature: 48F</Text>
        <Text>Wind Speed: 13mph</Text>
        <Text>Humidity: 8%</Text>
        <Text>Location:</Text>
        <Text>1 FOOT WEST OF ELEVATORS THRU NORTH WALL</Text>
        <Text>SOUTH EAST CORRIDOR ROOM 201</Text>
        <Button
          title="Cycle"
          onPress={cycleDamper}
          style={{ flex: 1 }}
        />
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
  render() {
    return (
      <View style={styles.container}>
        <Text>Select a Building</Text>
        <FlatList
          data={[{
            "id": 1,
            "key": "1",
            "alias_id": "RH",
            "building_name": "Rivington",
            "address1": "45 Rivington St.",
            "address2": "",
            "city": "New York",
            "state": "NY ",
            "zip": null,
            "poc": "Jerome Lucas",
            "poc_phone": "212-539-6258",
            "ho": null, "bo": null,
            "last_date_tested_ts": null,
            "isenabled": false,
            "occupancy": null,
            "lat": 40.72069500,
            "lng": -73.99112900
          }, {
            "id": 3,
            "key": "3",
            "alias_id": "BR",
            "building_name": "Basking Ridge",
            "address1": "136 Mountainview Blvd",
            "address2": "",
            "city": "Basking Ridge",
            "state": "NJ",
            "zip": "07920",
            "poc": "",
            "poc_phone": "",
            "ho": null,
            "bo": null,
            "last_date_tested_ts": null,
            "isenabled": false,
            "occupancy": null,
            "lat": 40.63960900,
            "lng": -74.58431500
          }, {
            "id": 23,
            "key": "23",
            "alias_id": "VNH",
            "building_name": "Village Nursing Home",
            "address1": "607 HUDSON ST",
            "address2": "",
            "city": "NEW YORK",
            "state": "NY",
            "zip": null,
            "poc": "Anthony Cruz",
            "poc_phone": "212-337-9332",
            "ho": null,
            "bo": null,
            "last_date_tested_ts": null,
            "isenabled": false,
            "occupancy": null,
            "lat": 40.73739600,
            "lng": -74.00616200
          }]}
          renderItem={({ item }) => <Button title={item.building_name + " " + item.address1} onPress={() => this.props.navigation.navigate('FloorList')} />}
        />
      </View>
    );
  }
}

class FloorScreen extends Component {
  render() {
    return (
      <View style={styles.container}>
        <Text>Select a Floor</Text>
        <FlatList
          data={[{
            "id": 952,
            "key": "18",
            "floor_id": 74,
            "building_id": 11,
            "alias_id": "SC-FD-001-2",
            "sizel": 0,
            "sizew": 0,
            "system": "Ahu",
            "systemtype": null,
            "location": "Southeast main corridor",
            "sublocation": "4 feet west of s-223",
            "dampernumber": 1,
            "series": 0,
            "date_tested_ts": "2013-09-16T00:00:00",
            "repair_date": null,
            "comments": "5/6/09-No access door found",
            "isenabled": false,
            "next_test_date": "2019-09-16T00:00:00",
            "occupancy": "HEALTH_CARE",
            "special_procedures": ""
          }]}
          renderItem={({ item }) => <Button title={item.floor_id + " " + item.location} onPress={() => this.props.navigation.navigate('DamperList')} />}
        />
      </View>
    );
  }
}

class DamperScreen extends Component {
  render() {
    return (
      <View style={styles.container}>
      <Text>Select a Damper to see details</Text>
        <FlatList
          data={[{
            "id": 952,
            "key": "1",
            "floor_id": 74,
            "building_id": 11,
            "alias_id": "SC-FD-001-2",
            "sizel": 0,
            "sizew": 0,
            "system": "Ahu",
            "systemtype": null,
            "location": "Southeast main corridor",
            "sublocation": "4 feet west of s-223",
            "dampernumber": 1,
            "series": 0,
            "date_tested_ts": "2013-09-16T00:00:00",
            "repair_date": null,
            "comments": "5/6/09-No access door found",
            "isenabled": false,
            "next_test_date": "2019-09-16T00:00:00",
            "occupancy": "HEALTH_CARE",
            "special_procedures": ""
          }]}
          renderItem={({ item }) => <Button title={item.building_id + " " + item.location} onPress={() => this.props.navigation.navigate('Details')} style={{ padding: 5 }} />}
        />
      </View>
    );
  }
}

class DetailsScreen extends Component {
  render() {
    const samplePic = {
      uri: 'https://martech.zone/wp-content/uploads/2010/06/example-logo.png'
    };
    const damperPic = {
      uri: 'https://www.hasman.co.uk/wp-content/uploads/2018/03/fire-damper.jpg'
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
        />
        <Button
          title="Go to Login Page"
          onPress={() => this.props.navigation.navigate('Login')}
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
});

const doThings = () => {
  alert('hi');
}

const pass = () => {
  alert('Pass');
}

const fail = () => {
  alert('Fail');
}

const cycleDamper = () => {
  alert('Cycle Damper');
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