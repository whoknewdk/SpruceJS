function define() {
	var args = arguments,
	    length = args.length,
	    keys = define.keys,

	    imports = [],
	    key, body,

	    i, j, val, type;

	for (i = 0; i < length; i++) {
		val = args[i];

		type = Object.prototype.toString.call(val);

		// Key
		if (type === '[object String]')
			key = val;

		// Imports
		if (type === '[object Array]') {
			for (j = 0; j < val.length; j++) {
				var _import = val[j];


				if (key)
				{
					var nameParts = key.split('/');


					// Single dot
					if (_import.indexOf('./') === 0) {
						var parts = nameParts.splice(0, nameParts.length - 1);

						parts.push(_import.replace('./', ''));
						_import = parts.join('/');
					}

					// Double dot
					if (_import.indexOf('../') === 0) {
						var dependencyParts = _import.split('../'),
							parts = nameParts.splice(0, dependencyParts.length-1);

						parts.push(_import.replace('../', ''));
						_import = parts.join('/');
					}
				}

				imports.push(keys[_import]);
			}
		}

		// Body
		if (type === '[object Function]')
			body = val;
	}

	keys[key || ""] = body.apply(this, imports);
}
define.amd = {};
define.keys = {};