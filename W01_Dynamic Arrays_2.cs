def rotate_list_right(data, amount):
    """
    Step by step plan:
    1. We need to rotate the list to the right by a certain amount.
    2. Rotating right means:
       - Take the last 'amount' elements
       - Move them to the front of the list
    3. Find where the split happens:
       splitIndex = len(data) - amount
    4. Get the last "amount" elements:
       data[splitIndex:]
    5. Get the first part:
       data[:splitIndex]
    6. Clear the original list.
    7. Add the last part first.
    8. Then add the first part.
    9. The list is now rotated.
    """

    split_index = len(data) - amount

    # Get the last "amount" items
    last_part = data[split_index:]

    # Get the first part of the list
    first_part = data[:split_index]

    # Clear original list
    data.clear()

    # Add last part first (rotated to front)
    data.extend(last_part)

    # Then add the first part
    data.extend(first_part)