SpruceJS
========
SpruceJS is a JavaScript module loader for ASP.NET. It will assemble your source files and resolve dependencies, instantly.

Features
========
* Module centric JavaScript development.
* Automatic dependency resolution.
* Debugging via sourcemaps.
* Minification
* Super fast run-time assembling. No build, just edit-save-refresh!
* < 1 KB JavaScript library required

Howto get started
=================
You can explore the different ways of using SpruceJS by heading over to the [Getting started guide](https://github.com/whoknewdk/SpruceJS/wiki/Getting-started). 
Basically though, it works as below.

**app.html**
```xml
<html>
	<body>
		<p id="msg"></p>
		<script src="app.spruce.js"></script>
	</body>
</html>
```

**HttpHandler**
```xml
<handlers>
	<add name="SpruceJS" verb="*" path="*.spruce.js*" type="SpruceJS.Web.SpruceJSHttpHandler,SpruceJS.Web" />
	<add name="NoCache" verb="*" path="*.js" type="SpruceJS.Web.Utils.NoCacheHttpHandler,SpruceJS.Web" />
</handlers>
```

**app.spruce.config**
```xml
<sprucejs>
	<modules>
		<add path="/shared/models/" />
		<add path="views/" />
	</modules>
</sprucejs>
```

**views/hello.js**
```javascript
define("views/hello", ["models/message"], function (message) {

	$('#msg').html(message.hello);

});
```

**/shared/models/hello.js**
```javascript
define("models/message", function () {
	return {
		hello: 'Hello'
	};
});
```

Copyright
=========
Copyright (c) 2013 Jacob T. Nielsen and contributors.

License
=======
SpruceJS is free software, distributed under the MIT License.
