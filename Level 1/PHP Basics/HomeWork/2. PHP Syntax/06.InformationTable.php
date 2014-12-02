</<!doctype html>
<head>
    <meta charset="UTF-8">
    <title>Information Table</title>
    <link rel="stylesheet" type="text/css" href="styles/06.InformationTable.css">
</head>
<body>
<?php
$name = "Gosho";
$phoneNumber = '0882-321-423';
$age = 24;
$address = "Hadji Dimitar";
?>
<table>
    <tr>
        <td>Name</td>
        <td><?php echo "$name" ?></td>
    </tr>
    <tr>
        <td>Phone Number</td>
        <td><?php echo "$phoneNumber" ?></td>
    </tr>
    <tr>
        <td>Age</td>
        <td><?php echo "$age" ?></td>
    </tr>
    <tr>
        <td>Address</td>
        <td><?php echo "$address" ?></td>
    </tr>
</table>
</body>
</html>


