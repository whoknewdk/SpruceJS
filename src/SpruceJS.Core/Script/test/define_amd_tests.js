/// <reference path="jasmine/jasmine.js"/>
/// <reference path="../spruce.js"/>

describe('define amd', function() {
	it('can define object', function () {
		define('a', function () { return 'a!'; });
		define('a/b', function () { return 'a/b!'; });
		define('a/b/c', function () { return 'a/b/c!'; });
	});
	
	it('can reference object', function () {
		define('a/b', function () { return 'ab!'; });

		define(['a/b'], function (ab) {
			expect(ab).toBe('ab!');
		});
	});
	
	it('can reference relative object', function () {
		define('a/b', function () { return 'ab!'; });

		define('a/c', ['./b'], function (ab) {
			expect(ab).toBe('ab!');
		});
	});
	
	it('can reference step out object', function () {
		define('a/b', function () { return 'ab!'; });

		define('a/c/d', ['../b'], function (ab) {
			expect(ab).toBe('ab!');
		});
	});
});