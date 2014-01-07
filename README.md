SpruceJS
========
SpruceJS is a JavaScript module assembler for ASP.NET. It will assemble your source files, resolve dependencies, minify the result and generate corresponding source maps.

This allows you to structure your JavaScript using AMD/CommonJS style modules all served to the browser in a single request.

Features
========
* Module centric JavaScript development.
* Automatic dependency resolution.
* Debugging via source maps.
* No build step. Edit-save-refresh!
* Minification.

How it works
============
SpruceJS supports the following module signatures.

* [CommonJS style](https://github.com/whoknewdk/SpruceJS/wiki/Module-signature)
* [AMD style](https://github.com/whoknewdk/SpruceJS/wiki/Module-signature)

The basic way of using SpruceJS uses a single JavaScript module as entry point.

**app.html**
```xml
<html>
	<body>
		<p id="msg"></p>
		<script src="hello.spruce.js"></script>
	</body>
</html>
```

**hello.js**
```javascript
define(function (require) {
	var message = require('./models/message');

	$('#msg').html(message.hello);
});
```

**models/message.js**
```javascript
define(function (require, exports) {
	exports.hello = 'Hello world!';
});
```

Setup
=====
**Http Handler**
```xml
<handlers>
	<add name="Spruce" verb="*" path="*.spruce.js*" type="SpruceJS.Web.SpruceHandler,SpruceJS.Web" />
</handlers>
```

**ASP.NET MVC**
You will also need to ignore the route for it to work.

```csharp
routes.IgnoreRoute("{*spruce}", new { spruce = @".*\.spruce\.js" });
```

Publishing
==========
Using the SpruceJS [Build Task](https://github.com/whoknewdk/SpruceJS/wiki/Publishing-sprucejs) you can automatically unregister the Http Handler and genenerate at static JavaScript file in its place. This means you will only use the Http Handler during development and instead serve a static file in production.

Read more about [publishing SpruceJS](https://github.com/whoknewdk/SpruceJS/wiki/Publishing-sprucejs)

Documentation
=============
* [Using SpruceJS](https://github.com/whoknewdk/SpruceJS/wiki/Module-signature)
* [Publishing SpruceJS](https://github.com/whoknewdk/SpruceJS/wiki/Module-signature)
* Entire [Documentation](https://github.com/whoknewdk/SpruceJS/wiki).

Copyright
=========
Copyright (c) 2013 Jacob T. Nielsen.

License
=======
SpruceJS is free software, distributed under the MIT License.
