<!DOCTYPE html>
<html>
<head>
    <title>01.Square Root Sum</title>
    <style>
        table {
            border-collapse: collapse;
        }
        table thead tr td {
            background: #86d2ff !important;
            color: #fff;
        }
        table td {
            border: solid 1px #cecece;
            padding: 5px;
        }

        table td:first-child {
            font-style: italic;
        }
    </style>
</head>
<body>
<table>

    <thead>
    <tr>
        <td>Number</td>
        <td>Square</td>
    </tr>
    </thead>

    <tbody>
    <?php
    $total = 0;
    for($i = 0; $i <= 100; $i += 2):
        $sqrt = sqrt($i);
        $roundedSqrt = round($sqrt,2);
        $total += $sqrt;
        ?>
        <tr>
            <td><?= $i; ?></td>
            <td><?= $roundedSqrt; ?></td>
        </tr>
    <?php
    endfor;
    ?>
    </tbody>

    <tfoot>
    <tr>
        <td>Total</td>
        <td><?= round($total, 2); ?></td>
    </tr>
    </tfoot>

</table>
</body>
</html>