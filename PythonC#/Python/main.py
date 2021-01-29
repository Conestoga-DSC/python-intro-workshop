def add(a, b):
    return a + b


def sub(a: int, b: int) -> int:
    return a - b


if __name__ == "__main__":
    # variables and types
    a = 1
    a: int = 1

    b = "hello DSC!"
    l = [1, "asd", True]
    d = {"key": "value", "key2": 23}

    # lists
    l = [1, "asd", True, None, 23.4]

    l2 = [i * 2 for i in range(10)]
    print(l2)

    print("Last element:", l2[-1])
    print("2nd and 3rd element:", l2[1:3])

    # if, for, while
    cnt = -1

    if cnt > 100:
        print("Unreal")
    elif cnt > 50:
        print("Hardly possible")
    else:
        print("This will run")

    for i in range(5, 10, 2):
        print(i)

    cnt = 0
    while cnt < 10:
        cnt += 1

    # functions
    print(add(1, 2))
    print(add("spam", "eggs"))

    print(sub(145, 89))
    print(sub("spam", "eggs"))
