SpruceJS
========
SpruceJS is a JavaScript module assembler for ASP.NET. It will assemble your source files, resolve dependencies, minnify everything and generate corresponding source maps.

Features
========
* Module centric JavaScript development.
* Automatic dependency resolution.
* Debugging via source maps.
* Minification.
* No build step. Just edit-save-refresh!
* < 1 KB JavaScript library required.

Howto get started
=================
You can explore the different ways of using SpruceJS by heading over to the [Getting started guide](https://github.com/whoknewdk/SpruceJS/wiki/Getting-started). 
Basically though, it works as below.

**HttpHandler**
```xml
<handlers>
	<add name="SpruceJS" verb="*" path="*.spruce.js*" type="SpruceJS.Web.SpruceJSHttpHandler,SpruceJS.Web" />
</handlers>
```

**app.html**
```xml
<html>
	<body>
		<p id="msg"></p>
		<script src="app.spruce.js"></script>
	</body>
</html>
```

**app.json**
```javascript
{
	modules: [
		'views/*.js'
	]
}
```

**views/hello.js**
```javascript
define(function (require) {
	var message = require('models/message');

	$('#msg').html(message.hello);
});
```

**models/message.js**
```javascript
define(function (require, exports) {
	exports.hello = 'Hello world!';
});
```

Copyright
=========
Copyright (c) 2013 Jacob T. Nielsen.

License
=======
SpruceJS is free software, distributed under the MIT License.
