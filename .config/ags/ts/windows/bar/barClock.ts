// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
import { BarWidget} from "./barWidget";

const clock_revealer = Widget.Revealer({
    transition: "slide_left",
    transitionDuration: 500,
    css: "padding-left: 10px;", // add padding when shown
    child: Widget.Label().poll(1000, widget => {
        const datetime = new Date();
        const day = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"][datetime.getDay()];
        const month = [
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December",
        ][datetime.getMonth()];
        const year = datetime.getFullYear();
        const date = String(datetime.getDate()).padStart(2, "0");
        widget.label = `${day}, ${date} ${month} ${year}`;
    }),
});

export const BarClock = Widget.EventBox({
    class_name: "clock",
    on_primary_click: () => clock_revealer.reveal_child = !clock_revealer.reveal_child,
    // on_hover: () => clock_revealer.reveal_child = true,
    // on_hover_lost: () => clock_revealer.reveal_child = false,
    child: Widget.Box({
        children: [
            Widget.Label({
                class_name: "glyph",
            }).poll(1000, widget => widget.label = new Date().toLocaleTimeString("en-gb", {hour12: false})),
            clock_revealer,
        ],
    }),
});
