import os

main_dir = os.getcwd() + "\\Assembly-CSharp\\Assembly-CSharp"


def empty_methods(path):
    spl = str(path).split("\\")
    name = spl[-1].split(".cs")[0]
    file_open = open(main_dir + "\\..\\out.txt", 'a')
    file_open.write(f"[assembly: TypeForwardedTo(typeof({name}))]\n")

def main(_dir):
    for item in os.scandir(_dir):
        if item.is_file():
            if item.name.endswith(".cs"):
                empty_methods(item.path)
        else:
            main(item.path)

main(main_dir)