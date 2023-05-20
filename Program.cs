string twFileInput = "tailwindGenerated.css";
string twFileOutput = "tailwindForLit.ts";
string twFolder = @"./";

string twFileContents = File.ReadAllText(Path.Combine(twFolder, twFileInput));
string twFileContentsSanitized = twFileContents.Replace("`", "");
string template = $"import {{ css }} from \"lit\"; export const TWStyles = css`{twFileContentsSanitized}`";

File.WriteAllText(Path.Combine(twFolder, twFileOutput), template);

