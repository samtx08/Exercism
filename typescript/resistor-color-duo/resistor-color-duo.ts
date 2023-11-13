export const COLORS = ['black', 'brown', 'red', 'orange', 'yellow', 'green', 'blue', 'violet', 'grey', 'white'] as const;
type Colors = typeof COLORS[number];

export const decodedValue = ([first, second]: Colors[]) => COLORS.indexOf(first) * 10 + COLORS.indexOf(second);
