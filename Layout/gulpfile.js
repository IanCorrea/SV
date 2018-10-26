var gulp = require('gulp')
    ,imagemin = require('gulp-imagemin')
    ,clean = require('gulp-clean')
	,uglify = require('gulp-uglify')
	,usemin = require('gulp-usemin')
	,cssmin = require('gulp-cssmin')
	,browserSync = require('browser-sync')
	,jshint = require("gulp-jshint")
	,jshintStylish  = require('jshint-stylish')
	,csslint = require('gulp-csslint')
	,sasslint = require('gulp-sass-lint')
	,fileinclude = require('gulp-file-include')
	,extReplace = require('gulp-ext-replace')
	stringReplace = require('gulp-string-replace');

gulp.task('default', ['copy'], function(){

	gulp.start('build-img', 'string-replace');
});

gulp.task('interface', function(){

	gulp.start('interface-cshtml', 'interface-js', 'interface-css', 'interface-img', 'interface-fonts');
});

gulp.task('copy', ['clean'], function() {

    return gulp.src('src/**/*') //the return completes the process
        .pipe(gulp.dest('dist'));
});

gulp.task('clean', function() {

    return gulp.src('dist')
        .pipe(clean());
});

gulp.task('build-img', function() {

    gulp.src('dist/img/**/*')
        .pipe(imagemin())
        .pipe(gulp.dest('dist/img'));
});

gulp.task('usemin', function(){

	return gulp.src('dist/**/*.html')
		.pipe(usemin({
			'js' : [uglify],
			'css': [cssmin]
		}))
		.pipe(gulp.dest('dist'));
});

gulp.task('string-replace', ['usemin'], function() {

  gulp.src(["dist/*.html"])
  	.pipe(stringReplace('src="interface-', 'src="'))
    .pipe(stringReplace('href="interface-', 'href="~/'))
    .pipe(stringReplace('src="', 'src="~/'))
    .pipe(stringReplace('<!-- Title -->', '@ViewBag.Title'))
    .pipe(stringReplace('<!-- _Layout-Head -->', "@@include('../interface-Templates/_Layout-Head.html')"))     
    .pipe(stringReplace('panel-home', '@ViewBag.PanelType'))
    .pipe(stringReplace('panel title', '@ViewBag.PanelTitle'))
    .pipe(stringReplace('<!-- RenderBody -->', '@RenderBody()'))
    .pipe(stringReplace('<!-- _Layout-Scripts -->', "@@include('../interface-Templates/_Layout-Scripts.html')"))
       
    .pipe(gulp.dest('dist/interface-Views/'))
});



gulp.task('interface-js', function() {

	 gulp.src('dist/interface-Scripts/**/*')
    .pipe(gulp.dest('../ProjetoDDD/ProjetoDDD.MVC/Scripts'));
});

gulp.task('interface-css', function() {

    gulp.src('dist/interface-Content/**/*')
    .pipe(gulp.dest('../ProjetoDDD/ProjetoDDD.MVC/Content'));
});

gulp.task('interface-img', function() {

    gulp.src('dist/img/**/*')
    .pipe(gulp.dest('../ProjetoDDD/ProjetoDDD.MVC/img'));
});

gulp.task('interface-fonts', function() {

    gulp.src('dist/fonts/**/*')
    .pipe(gulp.dest('../ProjetoDDD/ProjetoDDD.MVC/fonts'));
});

gulp.task('interface-cshtml', function() {
  gulp.src(['dist/interface-Views/_Layout.html'])
    .pipe(fileinclude({
      prefix: '@@',
      basepath: '@file'
    }))
    .pipe(extReplace('.cshtml'))
    .pipe(gulp.dest('../ProjetoDDD/ProjetoDDD.MVC/Views/Shared'));
    //.pipe(gulp.dest('test/cshtml'));
});

gulp.task('server', function(){

	browserSync.init({

		server: {
			baseDir: ['src'],
			index: "_Layout.html"
		}
	});

	gulp.watch('src/js/*.js').on('change', function(event){
		gulp.src(event.path)
		.pipe(jshint())
		.pipe(jshint.reporter(jshintStylish));
	});

//	csslint.addFormatter('csslint-stylish')
	//	gulp.watch('src/css/style.css').on('change', function(event){
	//	gulp.src(event.path)
	//	.pipe(csslint())
	//	.pipe(csslint.formatter('stylish'));
	//});

	gulp.watch('scss/*.scss').on('change', function(event){
		gulp.src(event.path)
		.pipe(sasslint({
			configFile: '.sass-lint.yml'
		}))
		.pipe(sasslint.format());
	});

	gulp.watch('src/**/*').on('change', browserSync.reload);
});
