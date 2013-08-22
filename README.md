SpruceJS
========
SpruceJS is a JavaScript module loader for ASP.NET. It will assemble and resolve dependencies for all your source files, instantly.

Features
========
* Module centric JavaScript development.
* Automatic dependency resolution.
* Debugging via sourcemaps.
* Super fast run-time assembling. No build. Edit-save-refresh!
* < 1 KB JavaScript library required (you can even roll your own).
* OnPublish static file generation.
* And best of all... No application/listener running in the background!

Howto get started
=================
You explore the different ways of using SpruceJS by heading over to the [Getting started guide](https://github.com/whoknewdk/SpruceJS/wiki/Getting-started). 
Basically though, it works as below.

HttpHandler
	...
	<handlers>
		<add name="SpruceJS" verb="*" path="*.spruce.js*" type="SpruceJS.Web.SpruceJSHttpHandler,SpruceJS.Web" />
		<add name="NoCache" verb="*" path="*.js" type="SpruceJS.Web.Utils.NoCacheHttpHandler,SpruceJS.Web" />
	</handlers>
	...

app.spruce.config
	<sprucejs>

		<modules>
			<add path="/shared/models/" />
			<add path="views/" />
		</modules>

	</sprucejs>

views/hello.js
	define("views/hello", ["models/hello"], function (hello) {
		return {
			say: function () {
				alert(hello.message);
			}
		};
	});

/shared/models/hello.js
	define("models/hello", function () {
		return {
			message: 'Hello'
		};
	});

Copyright
=========
Copyright (c) 2013 Jacob T. Nielsen and contributors.

License
=======
SpruceJS is free software, distributed under the MIT License.