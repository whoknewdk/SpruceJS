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

		// Imports
		if (type === '[object Array]') {
			for (j = 0; j < val.length; j++) {
				imports.push(keys[val[j]]);
			}
		}
		
		// Key
		if (type === '[object String]')
			key = val;
		
		// Body
		if (type === '[object Function]')
			body = val;
	}

	keys[key || ""] = body.apply(this, imports);
}
define.keys = {};