/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var zip = require('gulp-zip');
var fs = require('fs');
var replace = require('gulp-replace');

gulp.task('default', function () {
    // This file isnt commited to source as its the keys, normally this runs via VSOnline build pipeline variables
    var botId = fs.readFileSync("botid.txt", "utf8");

    gulp.src('TeamsAppPackage/*')
        .pipe(replace('%BOT_FRAMEWORK_ID%', botId))
        .pipe(zip('silverstoneteamsapp.zip'))
        .pipe(gulp.dest('dist'))
});