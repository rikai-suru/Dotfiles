#!/bin/zsh
# change_zsh_themes_based_on_time

scripts="$HOME/scripts"

# Check if an override parameter is provided
theme="dark"

if [ "$theme" = "light" ]; then
	if [ "$TERM" = "linux" ]; then
		"$scripts/settings/tty/tty-rosepine-dawn.sh"
	fi

elif [ "$theme" = "dark" ]; then
	if [ "$TERM" = "linux" ]; then
		"$scripts/settings/tty/tty-rosepine-moon.sh"
	fi

else
	echo "Something wrong happened."
fi

# # Light Theme, 6 AM - 7 PM
# if [ "$current_hour" -ge 6 ] && [ "$current_hour" -lt 19 ]; then
# 	# TTY
# 	# alacritty
# 	if [ "$TERM" = "alacritty" ]; then
# 		sed -i "s/$night_theme/$day_theme/g" "$alacritty_config_path"
# 	fi
# # Rose Pine Moon, 7 PM - 6 AM
# elif [ "$current_hour" -lt 6 ] || [ "$current_hour" -lt 24 ]; then
# 	# TTY
# 	if [ "$TERM" = "linux" ]; then
# 		# tty
# 	fi
# 	# alacritty
# 	if [ "$TERM" = "alacritty" ]; then
# 		sed -i "s/$day_theme/$night_theme/g" "$alacritty_config_path"
# 	fi
# else
# 	# You're not supposed to reach this.
#     echo "Something in theme didn't work: $current_hour"
# fi