import sys
import os
NAMESPACE_IDENTIFIER = "// Namespace: "
DEFINITION_IDENTIFIER = "// TypeDefIndex"
KEYWORDS = ["class", "struct", "enum", "interface"]

if __name__ == "__main__":
    source_file = sys.argv[1]
    with open(source_file, encoding="utf8") as fs:
        lines = fs.readlines()
        # Lines starting with the namespace identifier
        start_indices = [index for index in range(len(lines)) if lines[index].startswith(NAMESPACE_IDENTIFIER)]

        for i in range(0, len(start_indices), 2):
            line: str = lines[start_indices[i]]
            
            namespace = line[len(NAMESPACE_IDENTIFIER):].replace(".", "/").strip()
            if namespace == "":
                namespace = "no_namespace"

            if os.path.exists(namespace) == False:
                print(f"Namespace: {namespace}")
                os.makedirs(namespace)
            
            # Check for attributes
            definition_start = 1
            while True:
                if DEFINITION_IDENTIFIER not in lines[start_indices[i] + definition_start]:
                    definition_start += 1
                else:
                    break

            line_start = 0
            for x in KEYWORDS:
                if x in lines[start_indices[i] + definition_start]:
                    line_start = lines[start_indices[i] + definition_start].index(x) + len(x) + 1
            
            name = str()
            slice = lines[start_indices[i] + definition_start][line_start:]
            for char in slice:
                if char.isalpha():
                    name += char
                else:
                    break

            body = lines[start_indices[i]:start_indices[i+1]]

            file_path = f"{namespace}/{name}.cs"
            with open(file_path, "wt", encoding="utf8") as fs:
                fs.writelines(body)