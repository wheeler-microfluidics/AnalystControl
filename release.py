import sys
sys.path.insert(0, '.')
import version

open('RELEASE-VERSION', 'wb').write(version.getVersion())
