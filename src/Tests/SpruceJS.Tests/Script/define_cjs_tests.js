/// <reference path="../../../SpruceJS.Core/Script/spruce-define.js"/>

describe('define commonjs', function() {
	it('can define object', function () {
		define('a', function () { return 'a!'; });
		define('a/b', function () { return 'a/b!'; });
		define('a/b/c', function () { return 'a/b/c!'; });
	});
	
	it('can reference object', function () {
		define('a/b', function (require, exports) { exports.msg = 'ab!'; });

		define(function(require) {
			var ab = require('a/b');
			expect(ab.msg).toBe('ab!');
		});
	});
	
	it('can reference relative object', function () {
		define('a/b', function () { return 'ab!'; });

		define('a/c', function (require) {
			var ab = require('./b');
			expect(ab).toBe('ab!');
		});
	});
	
	it('can reference step out object', function () {
		define('a/b', function () { return 'ab!'; });

		define('a/c/d', function (require) {
			var ab = require('../b');
			expect(ab).toBe('ab!');
		});
	});
});