import os

main_dir = os.getcwd() + "\\Assembly-CSharp\\Visor"

def empty_methods(path):
    with open(path) as f: s = f.read()
    if not "using PlasmaAPI.GameClass.Behavior;" in s:
        s = "using PlasmaAPI.GameClass.Behavior;\n" + s
    file_open = open(path, 'w')
    file_open.write(s)

def main(_dir):
    for item in os.scandir(_dir):
        if item.is_file():
            if item.name.endswith(".cs"):
                empty_methods(item.path)
        #else:
        #    main(item.path)

main(main_dir)