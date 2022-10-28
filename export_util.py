import os

main_dir = os.getcwd() + "\\Export\\Assembly-CSharp"

valid_items = [ "protected", "private", "public", "virtual", "abstract" ]

VisorFiles = [ "DisplayUIElement.cs", "VisorUIController.cs", "WorldController.cs" ]

def empty_methods(path):
    with open(path) as f: s = f.read()
    if str(path).split("\\")[-1] in VisorFiles:
        s = s.replace("Visor", "Visor.Visor")
        s = s.replace("using Visor.Visor;", "using Visor;")
    lines = s.split('\n')
    lnNumber = 0
    methods = []
    for line in lines:
        if line.strip().split(' ')[0] in valid_items:
            lineNum = lnNumber - 1
            for k in range(lnNumber - 5, lnNumber):
                if lines[k].strip().startswith("// Token: "):
                    lineNum = k
                    break
            methods.append({"LineNumber0": lineNum, "LineNumber1": lnNumber, "Line": line.strip(), "IsMethod": ("(" in line.strip())& (")" in line.strip()) & (";" not in line.strip()), "HasReturn": ("void" not in line.strip()) & (line.strip().count(' ') > 1) })
        lnNumber += 1
    
    for index in range(len(methods)):
        item = methods[index]
        if item["IsMethod"]:
            snum = item["LineNumber1"] + 2
            num = snum
            prefix = "    "
            target = lines[snum-1].replace("	" , "0").count('0') * 4
            for _ in range(target):
                prefix = prefix + " "
            if index+1 < len(methods):
                num = methods[index+1]["LineNumber0"] - 2
            else:
                for ln in range(snum, len(lines)):
                    if "}" in lines[ln]:
                        if target == lines[ln].replace("	" , "0").count('0') * 4:
                            num = ln
            repl = [""] * (num - snum)
            insrt = []
            pindex = 0
            for param in str(item["Line"]).split("(")[1].split(")")[0].split(", "):
                if "out " in param:
                    param_s = prefix + param.split(" ")[2] + " = default;"
                    if pindex >= len(repl):
                        insrt.append(param_s)
                    else:
                        repl[pindex] = param_s
                    pindex+=1
            if lines[snum].strip() != "}":
                for subline in range(snum, num):
                    lines[subline] = repl[subline - snum]
                for app in insrt:
                    lines.insert(snum, app)
                if item["HasReturn"] and str(item["Line"]).split('(')[0].strip().count(' ') > 1:
                    lines[num] = prefix + "return default;\n" + prefix[4:] + "}"

    file = "\n".join(lines)
    while("\n\n\n" in file):
       file = file.replace("\n\n\n", "\n\n")
    #print(file)
    file_open = open(path, 'w')
    file_open.write(file)

def main(_dir):
    for item in os.scandir(_dir):
        if item.is_file():
            if item.name.endswith(".cs"):
                empty_methods(item.path)
        else:
            main(item.path)

main(main_dir)