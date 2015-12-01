import os
import sys

class Application(object):
    ignored_directories = ["textures", "commander", "gui"]

    material_template = """
singleton Material({name})
{opening}
    diffuseMap[0] = "{path}";
    mapTo = "{name}";
{closing};
    """

    def main(self):
        if (len(sys.argv) != 3):
            print("Usage: %s <material dir>  <output material script>" % sys.argv[0])
            print("material dir is the root of the directory in which the Tribes 2 materials can be found.")
            print("output material script is the output script for Torque3D that allows proper material usage.")
            return

        material_directory = sys.argv[1]
        output_location = sys.argv[2]

        os.chdir(sys.argv[1])

        # In this list we store dictionaries that store a name and a path
        materials = [ ]

        # First, we generate a listing of the T2 matlist
        for path, directories, files in os.walk(".", topdown=True):
            # Don't recurse textures
            if (path == "."):
                for exclusion in self.ignored_directories:
                    try:
                        directories.remove(exclusion)
                    except ValueError: pass

                continue

            for file in files:
                if (os.path.isfile(file) is not True):
                    continue

                full_path = os.path.join(path, file)[2:]

                material_name = os.path.basename(full_path)
                material_name = os.path.splitext(material_name)[0].upper()
                material_name = material_name.replace(".", "")

                material = { "name": material_name, "path": full_path, "opening": "{", "closing": "}" }
                materials.append(material)

        # Now dump the output and we should be golden.
        try:
            with open(output_location, "w") as output_handle:
                for material in materials:
                    output_handle.write(self.material_template.format(**material))

            print("Wrote output to %s." % output_location)
        except OSError as e:
            print("FATAL: Failed to open %s for read or %s for write!" % (input_location, output_location))

if __name__ == "__main__":
    Application().main()

#singleton Material( BlankWhite )
#{
#   diffuseMap[0] = "core/art/white";
#   mapTo = "white";
#   materialTag0 = "Miscellaneous";
#};
