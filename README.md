SpruceJS
========
SpruceJS is a JavaScript module assembler for ASP.NET. It will assemble module your source files, resolve dependencies, minify the result and generate corresponding source maps. All in a single request.

This allows you to structure your JavaScript using AMD/CommonJS style modules all served to the browser in a single request.

Features
========
* Module centric JavaScript development.
* Automatic dependency resolution.
* Debugging via source maps.
* No build step. Edit-save-refresh!
* Minification.

How it works
=================
You can explore the different ways of using SpruceJS by heading over to the [Documentation](https://github.com/whoknewdk/SpruceJS/wiki). 
Basically though, it works as below.

**app.html**
```xml
<html>
	<body>
		<p id="msg"></p>
		<script src="my-custom-name.spruce.js"></script>
	</body>
</html>
```

**my-custom-name.json**
```javascript
{
	modules: [
		'views/hello.js'
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

**HttpHandler**
```xml
<handlers>
	<add name="Spruce" verb="*" path="*.spruce.js*" type="SpruceJS.Web.SpruceHandler,SpruceJS.Web" />
</handlers>
```

Copyright
=========
Copyright (c) 2013 Jacob T. Nielsen.

License
=======
SpruceJS is free software, distributed under the MIT License.
