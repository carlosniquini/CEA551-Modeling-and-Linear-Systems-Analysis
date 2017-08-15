#https://matplotlib.org/api/pyplot_api.html
#https://matplotlib.org/users/pyplot_tutorial.html

import matplotlib.pyplot as plt
import numpy as np

x = np.arange(0, 5, 0.1)
y = np.sin(x)
plt.show()

t = np.arange(0, 150, 1);

def q(q0):
	return 25 + (q0 - 25)*np.exp(-3*t/100)

plt.plot(t, q(50),t, q(40), t, q(25), t, q(10))
plt.show()