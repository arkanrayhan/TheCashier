# TheCashier
Aplikasi ini membantu kasir untuk menghitung jumlah belanjaan pelanggan

## Fungsionalitas
- User dapat memasukkan tipe belanjaan
- User dapat memasukkan jumlah belanjaan
- User dapat memasukkan harga belanjaan
- User dapat menekan tombol tambahkan
- etc.

## Penjelasan Kode
Single Responsibility Pattern Single responsibility bermakna bertanggung jawab pada setiap individu. Dalam konteks pemrograman OOP, hal ini bermakna setiap class atau fungsi bertanggung jawab secara mandiri. Contoh dari Class tersebut hanya fokus kepada tanggung jawab nya ia sendiri

```
class Item
{
    private int id;
    private string title { get; set; }
    public int quantity { get; set; }
    public double price { get; set; }
    public double subtotal { get; set; }
    private string type;
    }
```
dan buat class baru untuk tanggung jawab yang lain
```
class Calculator
{
    private List<Item> listItem;
    private double total = 0;
    }
```
