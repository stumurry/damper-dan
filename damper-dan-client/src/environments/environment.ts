// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  // Initialize Firebase
  firebaseConfig : {
    apiKey: "AIzaSyCd-SKOQlDWTxsYIEbBrKi6ojJ-cxmVcLo",
    authDomain: "zekes-44376.firebaseapp.com",
    databaseURL: "https://zekes-44376.firebaseio.com",
    projectId: "zekes-44376",
    storageBucket: "zekes-44376.appspot.com",
    messagingSenderId: "977375997610"
  },

  GoogleMapKey : "AIzaSyB0U8UcaRCdpkk-45jlLOpuqsjr3PsJtts",

  facilities : 'http://localhost:5000/api/facilities'
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


