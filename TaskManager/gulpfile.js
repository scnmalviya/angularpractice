var gulp = require("gulp");
gulp.task("Copy-dist-to-wwwroot",()=>{
    return gulp.src("./dist/TaskManager/**/*").
    pipe(gulp.dest("F:\\dotnet\\Angular\\Practice\\MvcTaskManager\\TaskManagerWeb\\wwwroot"));
});

gulp.task("default",()=>{
    gulp.watch("./dist/TaskManager",gulp.series("Copy-dist-to-wwwroot"));
});

