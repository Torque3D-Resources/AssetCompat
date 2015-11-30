import os
import io
import sys
f = open ('../t3mats.txt','r')
tf = open('materials.cs','w')
for name in f:
	tf.write('singleton Material( "'+name.split('compat\\base\\textures\\')[-1].upper().replace('.png','').replace('.PNG','').rstrip("\n\r").split('\\')[-1]+'" )\n')
	tf.write('{\n')
	tf.write('diffuseMap[0] = "'+name.split('compat\\base\\textures\\')[-1].replace("\\","/").rstrip("\n\r")+'";\n')
	tf.write('mapTo = "'+name.split('compat\\base\\textures\\')[-1].upper().replace('.png','').replace('.PNG','').rstrip("\n\r").split('\\')[-1]+'";\n')
	tf.write('\n')
	tf.write('};\n')
tf.close()
#singleton Material( BlankWhite )
#{
#   diffuseMap[0] = "core/art/white";
#   mapTo = "white";
#   materialTag0 = "Miscellaneous";
#};
