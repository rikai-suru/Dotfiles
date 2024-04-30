// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
// @ts-ignore
import { EventBoxProps } from "types/widgets/eventbox.js";
// @ts-ignore
import { BoxProps } from "types/widgets/box.js";

interface BarWidgetProps {
    class_name: string;
    eventbox?: EventBoxProps;
    box?: BoxProps;
}

export function BarWidget({ class_name, eventbox, box }: BarWidgetProps) {
    return Widget.EventBox({
        class_name: class_name,
        ...eventbox,
        child: Widget.Box({
            class_name: "widget",
            ...box,
        }),
    });
}

