# tnb-remote-control-plugin
Plugin made for [TheNoobBot](http://thenoobbot.com/) - The first WoW Bot in the world compatible with WoW Legion.<br>
It was meant to be used together with mobile app called [Remote Bot Control](https://github.com/drptbl/remotecontrol-app) - also made by me.<br>
Everything was planned to run under pay-by-month model (that's why you can see auth everywhere, etc).

Currently it's main and only purpose is to:
- first authenticate user using `Firebase Auth`
- then send current botting character data to `Firebase Database` at set interval (for ex. each `10` secs)

But hey.. that doesn't sound useful yet, huh?<br>
What if you could combine this plugin together with mobile app?<br>
This would allow you to monitor your character `24/7` directly from your mobile phone.

What was planned for future?
- sending notifications from plugin to mobile app (started working on it, didn't finish)
- receiving remote commands:
    - for example you could set some value on button press in mobile app and then react to it with plugin and set it back to default value

Sadly - a lot of ideas, but no time left.<br>
That was my first touch of C#. And it was a pleasure actually!

# How to use?
- Change settings in `./PrivateSettings.cs` file
- Compile
- Throw it to TNB `/plugins` folder and have fun!