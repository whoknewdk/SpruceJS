function define() {
	var args = arguments,
	    length = args.length,
	    keys = define.keys,

	    key, body,

	    i, val, type;

	for (i = 0; i < length; i++) {
		val = args[i];

		type = Object.prototype.toString.call(val);

		// Key
		if (type === '[object String]')
			key = val;

		// Body
		if (type === '[object Function]')
			body = val;
	}


	function require(_import) {

		if (key) {
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
		
		return keys[_import];
	}

	keys[key || ""] = body.call(this, require);
}
define.amd = {};
define.keys = {};