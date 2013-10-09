var define;
(function () {

	var keys = {};

	define = function() {
		var args = arguments,
		    length = args.length,
		    imports = [],
		    key, body,
		    i, val, type;

		for (i = 0; i < length; i++) {
			val = args[i];

			type = Object.prototype.toString.call(val);

			// Key
			if (type === '[object String]')
				key = val;

			// Imports
			if (type === '[object Array]')
				readAmdImports(key, val, imports);

			// Body
			if (type === '[object Function]')
				body = val;
		}

		if (imports.length > 0) {
			keys[key || ""] = body.apply(this, imports);
		} else {
			var exp = keys[key || ""] = {};
			
			var result = body.call(this, function (_import) { return require(key, _import); }, exp);
			if (result)
				keys[key || ""] = result;
		}
	};
	define.amd = {};
	

	function readAmdImports(key, val, imports) {
		var j, _import, dependencyParts, parts;

		for (j = 0; j < val.length; j++) {
			_import = val[j];


			if (key) {
				var nameParts = key.split('/');


				// Single dot
				if (_import.indexOf('./') === 0) {
					parts = nameParts.splice(0, nameParts.length - 1);

					parts.push(_import.replace('./', ''));
					_import = parts.join('/');
				}

				// Double dot
				if (_import.indexOf('../') === 0) {
					dependencyParts = _import.split('../');
					parts = nameParts.splice(0, dependencyParts.length - 1);

					parts.push(_import.replace('../', ''));
					_import = parts.join('/');
				}
			}

			imports.push(keys[_import]);
		}
	}
	
	function require(key, _import) {
		var parts, dependencyParts;

		if (key) {
			var nameParts = key.split('/');

			// Single dot
			if (_import.indexOf('./') === 0) {
				parts = nameParts.splice(0, nameParts.length - 1);

				parts.push(_import.replace('./', ''));
				_import = parts.join('/');
			}

			// Double dot
			if (_import.indexOf('../') === 0) {
				dependencyParts = _import.split('../');
				parts = nameParts.splice(0, dependencyParts.length - 1);

				parts.push(_import.replace('../', ''));
				_import = parts.join('/');
			}
		}

		return keys[_import];
	}

}());