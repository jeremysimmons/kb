14 Least Known WordPress Constants

https://wisdmlabs.com/blog/14-least-known-wordpress-constants-an-overview/

#1 DOING_AJAX
We don’t need to set this constant manually but it’s set by WordPress when AJAX is processed. When AJAX request is fired, WordPress scans the complete code and executes the callback associated with the AJAX request. You can use this constant to speed up your site’s processing a little. For example, let’s say you are designing an admin page and you know that your admin functionality is never going to use AJAX. You can put this functionality under an if ( is_admin() && ( ! defined( ‘DOING_AJAX’ ) || ! DOING_AJAX ) ) block to speed up AJAX processing.

You can also use this constant inside common functions which are called when an AJAX request is fired. You can use the DOING_AJAX constant appropriately to define a block which should/should not be executed when an AJAX request is executed.

#2 DOING_CRON
The DOING_CRON constant is similar to DOING_AJAX. If you have some common functions which get executed as a callback of a cron job, and want to do something in that function only when a cron is running, then you can use this constant DOING_CRON in your code to add a condition on that block. For example, if ( defined( ‘DOING_CRON ) && DOING_CRON ) { // do something }

#3 FS_METHOD
This constant is used to force the file system method. It can be set in wp-config.php. If you experience problems while uploading themes or plugins, or upgrading the WordPress core, then setting this constant might help. This constant can have one of these values: ‘direct’, ‘ssh2’, ‘ftpext’, or ‘ftpsockets’.

If none of the other values work for you, then set the value of this constant to ‘direct’. This will allow you (or admin users on your website) the possibility to upload themes and plugins or the core directly from the admin panel and without any authentication.

But do note, this can give way to security issues on your server if it is not properly configured. Therefore, you should remove this constant from wp-config.php file when you are done with updating or installing things.

#4 DISALLOW_FILE_EDIT
WordPress by default allows you to make changes in the plugin and theme files from your admin panel. As you can imagine, this has certain disadvantages. For example, someone who does not have any coding knowledge might access the editor and make some changes there, which might crash the website. Therefore, the best practice is to not allow anyone to edit plugin/theme files from the admin panel. This can be achieved by setting the value of the constant DISALLOW_FILE_EDIT to true in wp-config.php

#5 IMAGE_EDIT_OVERWRITE
If you edit your uploaded images frequently in WordPress, then you need to set this constant in your wp-config.php.

The IMAGE_EDIT_OVERWRITE constant when set to true, it replaces earlier versions of edits with newly edited images which saves good amount of disk space, if you generally play around with high quality images. (You can read more about this constant here.)

#6 CONCATENATE_SCRIPTS
When it comes to performance optimization, you might have seen speed test reports on Google, Yahoo or GTMetrix suggesting you to combine scripts. This is because when you combine the scripts, the number of HTTP requests made is reduced and the site can fetch more data in single request.

Well, when working with WordPress, the smart way to achieve this task, is to define the CONCATENATE_SCRIPTS constant in your wp-config.php to true. This constant enables compression and concatenation of scripts in WordPress. Once you enable this constant, you should notice the number of HTTP requests has reduced. But keep in mind that enabling this constant might increase the PHP execution time by a small amount because the compression and concatenation is performed by PHP.

#7 COMPRESS_SCRIPTS
If you just want to enable compression but do not want concatenation, you can enable this constant- COMPRESS_SCRIPTS. Enabling this constant will compress JavaScript files in order to reduce their size. Again, if you enable this constant, this might affect load time. So after enabling this constant, check if your total load time has increased or decreased. If it has increased, I suggest removing this constant.

#8 COMPRESS_CSS
Similar to JavaScript compression, WordPress also provides a constant to enable or disable compression of CSS files. If you want to enable the compression, all you have to do, is define this constant to true in wp-config.php file. Once again, you need to check your site’s total load time after enabling this constant!

#9 ENFORCE_GZIP
Another recommendation that you might notice in performance reports is- enable gzip.

Gzip reduces the total file size by a significant amount if you have several JS and CSS files. You can enable gzipping by setting the ENFORCE_GZIP constant to true. When this constant is set, files are compressed with Gzip and then sent to the client. When this constant is not set,  the compression method used by WordPress is deflate.

#10 WP_ALLOW_REPAIR
Did you know WordPress could optimize the database itself and also repair it?

It’s true! But in order to enable WordPress to optimize and repair the database, you need to set WP_ALLOW_REPAIR constant in your wp-config.php to true. Once this constant is set, go to http://yoursite.com/wp-admin/maint/repair.php and there you should be able to see an option to Repair and Optimize the database. Make sure you remove the constant from wp-config.php file once you have optimized or repaired the database.

#11 WP_LOCAL_DEV
If you have only one server where you host both your development and production sites, then this constant can help you a lot. You can set WP_LOCAL_DEV to true to turn on your development environment. You can have different databases for both sites but can have the same files. You can also write code which you’d want to work only on your development site, and not on your production site.

Mark Jaquith has written a pretty cool mu-plugin which deactivates those plugins which aren’t production ready. You can read more about this constant here.

#12 ERRORLOGFILE
If you are running WordPress Multisite and want to keep an eye on all SQL query related errors, then this constant can come handy. Set this constant in wp-config.php to the file path where the errors should be logged. WordPress will then log all errors that occur while executing SQL queries in this file. Do note, this constant should be used only when you are running WP Multisite.

#13 DIEONDBERROR
This is also a Multisite constant. ERRORLOGFILE ensures that WordPress logs all errors in a file. However, if you would rather prefer to view SQL errors immediately, you can set the DIEONDBERROR constant. Do make sure that you do not set this constant on a live/production site. Because, when this constant is set to true, WordPress terminates execution when any SQL error occurs and displays the error along with the erroneous query fired.

#14 CUSTOM_USER_TABLE/ CUSTOM_USER_META_TABLE
Have you ever come across a scenario when you want to share users between two (or more) different WordPress websites? (I am not talking about Multisite here).

Well if you have, you’ll probably also want not only to share the users’ data along with the possibility for the users to log into both websites with the same password. In this case, these two constants are pretty helpful.

For this to work the two different WordPress websites would have to share the same database, but they could have their own tables. With the help of these two constants, these websites can share the users between them. In wp-config.php, we need to set these constants. When these constants are set, both the WordPress websites search for users and add users in these two tables. What’s interesting is WordPress creates an orphaned role for newly added users, and hence it is recommended to install WP-Orphanage Extended plugin on your websites.