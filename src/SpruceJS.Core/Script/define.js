function define(key, imports, body) {
	var keys = define.keys,
		values = []
		body = body || imports;

	if (Object.prototype.toString.call(imports) === '[object Array]') {
		for (var i = 0; i < imports.length; i++) {
			var value = imports[i];
			values.push(keys[value]);
		}
	}

	keys[key] = body.apply(this, values);
}
define.keys = {};