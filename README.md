# TinderSharp
A .Net Standard 2.0 wrapper for the Tinder API

### License

* TinderSharp is under the Unlicense.
* We are also using Newtonsoft.Json, which has an MIT license.

### Contributions

* To develop this wrapper, I got the endpoints from https://github.com/fbessez/Tinder and https://gist.github.com/rtt/10403467

### Features

<table>
   <thead>
      <tr>
         <th>Endpoint</th>
         <th>Purpose</th>
         <th>Data?</th>
         <th>Method</th>
		 <th>State</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td>/auth</td>
         <td>For authenticating</td>
         <td>{'facebook_token': INSERT_HERE, 'facebook_id': INSERT_HERE}</td>
         <td>POST</td>
		 <td>Working</td>
      </tr>
	  <tr>
		 <td>/auth/login/accountkit</td>
		 <td>For SMS authentication (two-factor)</td>
		 <td>{'token': INSERT_HERE, 'id': INSERT_HERE, 'client_version':'9.0.1'}</td>
		 <td>POST</td>
		 <td>Implemented but not tested</td>
	  </tr>
      <tr>
         <td>/user/recs</td>
         <td>Get match recommendations</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/user/matches/_id</td>
         <td>Send Message to that id</td>
         <td>{"message": TEXT GOES HERE}</td>
         <td>POST</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/user/matches/match_id</td>
         <td>Unmatch person</td>
         <td>{}</td>
         <td>DELETE</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/user/_id</td>
         <td>Get a user's profile data</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not Implemented</td>
      </tr>
      <tr>
         <td>/user/ping</td>
         <td>Change your location</td>
         <td>{"lat": lat, "lon": lon}</td>
         <td>POST</td>
		 <td>Not Impemented</td>
      </tr>
      <tr>
         <td>/updates</td>
         <td>Get all updates since the given date -- inserting "" will give you all updates since creating a Tinder account (i.e. matches, messages sent, etc.)</td>
         <td>{"last_activity_date": ""} Input a timestamp: '2017-03-25T20:58:00.404Z' for updates since that time.</td>
         <td>POST</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>Get your own profile data</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>Change your search preferences</td>
         <td>{"age_filter_min": age_filter_min, "gender_filter": gender_filter, "gender": gender, "age_filter_max": age_filter_max, "distance_filter": distance_filter}</td>
         <td>POST</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) hide/show age</td>
         <td>{"hide_age":boolean}</td>
         <td>POST</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) hide/show distance</td>
         <td>{"hide_distance":boolean}</td>
         <td>POST</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) hide/show ads</td>
         <td>{"hide_ads":boolean}</td>
         <td>POST</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) Set Tinder Blend options to "Recent Activity": Shows more recently active users</td>
         <td>{"blend":"recency"}</td>
         <td>POST</td>
		 <td>Not Implemented</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) Set Tinder Blend options to "Optimal": Scientifically proven to get you more matches</td>
         <td>{"blend":"optimal"}</td>
         <td>POST</td>
		 <td>Not Implemented</td>
      </tr>
      <tr>
         <td>/profile</td>
         <td>(Tinder Plus Only) Set discovery settings to only people who already liked you</td>
         <td>{"discoverable_party":"liked"}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/passport/user/travel</td>
         <td>(Tinder Plus Only) Travel to coordinate</td>
         <td>{"lat":lat,"lon":lon}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/instagram/authorize</td>
         <td>Auth Instagram</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/v2/profile/spotify/</td>
         <td>Get Spotify settings</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/v2/profile/spotify/theme</td>
         <td>Set Spotify song</td>
         <td>{"id":song_id}</td>
         <td>PUT</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/profile/username</td>
         <td>Change your webprofile username</td>
         <td>{"username": username}</td>
         <td>PUT</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/profile/username</td>
         <td>Reset your webprofile username</td>
         <td>{}</td>
         <td>DELETE</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/meta</td>
         <td>Get your own meta data (swipes left, people seen, etc..)</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/v2/meta</td>
         <td>Get your own meta data from V2 API (extra data like "top_picks" info)</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Working</td>
      </tr>
      <tr>
         <td>/report/_id</td>
         <td>Report someone --&gt; There are only a few accepted causes... (see tinder_api.py for options)</td>
         <td>{"cause": cause, "text": explanation}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/like/_id</td>
         <td>Like someone a.k.a swipe right</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/pass/_id</td>
         <td>Pass on someone a.k.a swipe left</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/like/_id/super</td>
         <td>~Super Like~ someone a.k.a swipe up</td>
         <td>{}</td>
         <td>POST</td>
		 <td>Implemented but not tested</td>
      </tr>
      <tr>
         <td>/matches/{match id}</td>
         <td>Get a match from its id (thanks <a href="https://github.com/jtabet"> @jtabet </a>)</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/message/{message id}</td>
         <td>Get a message from its id (thanks <a href="https://github.com/jtabet"> @jtabet </a>)</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/passport/user/reset</td>
         <td>Reset your location to your real location</td>
         <td>{}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/passport/user/travel</td>
         <td>Change your swiping location</td>
         <td>{"lat": latitutde, "lon": longitude}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/user/{user_id}/common_connections</td>
         <td>Get common connection of a user</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/profile/job</td>
         <td>Set job</td>
         <td>{"company":{"id":"17767109610","name":"University of Miami","displayed":true},"title":{"id":"106123522751852","name":"Research Assistant","displayed":true}}</td>
         <td>PUT</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/profile/job</td>
         <td>Delete job</td>
         <td>{}</td>
         <td>DELETE</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/profile/school</td>
         <td>Set school(s)</td>
         <td>{"schools":[{"id":school_id}]}</td>
         <td>PUT</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/profile/school</td>
         <td>Reset school</td>
         <td>{}</td>
         <td>DELETE</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/message/{message_id}/like</td>
         <td>Like a message</td>
         <td>{}</td>
         <td>POST</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/v2/fast-match/preview</td>
         <td>Get the non blurred thumbnail image shown in the messages-window (the one showing the likes you received)</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/v2/fast-match/count</td>
         <td>Get the number of likes you received</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/giphy/trending?limit={limit}</td>
         <td>Get the trending gifs (tinder uses giphy) accessible in chat</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
      <tr>
         <td>/giphy/search?limit={limit}&query={query}</td>
         <td>Get gifs (tinder uses giphy) based on a search accessible in chat</td>
         <td>{}</td>
         <td>GET</td>
		 <td>Not implemented</td>
      </tr>
   </tbody>
</table>
