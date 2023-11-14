export const COLORS = ['black', 'brown', 'red', 'orange', 'yellow', 'green', 'blue', 'violet', 'grey', 'white'] as const;
type Colors = typeof COLORS[number];

const prefixes = [
  [10 ** 9, "giga"],
  [10 ** 6, "mega"],
  [10 ** 3, "kilo"],
] as const;

export const decodedResistorValue = ([first, second, third]: Colors[]) => {
  const [tens, ones, zeros] = [first, second, third].map((b) =>
    COLORS.indexOf(b)
    );
  let mainValue = (tens * 10 + ones) * 10 ** zeros;
  const [div, prefix] = prefixes.find(([d]) => mainValue >= d) ?? [1, ""];
  return `${mainValue / div} ${prefix}ohms`;
};