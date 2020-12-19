DELETE FROM `wp_options` WHERE `option_name` LIKE ('_transient_%');
DELETE FROM `wp_options` WHERE `option_name` LIKE ('_site_transient_%');