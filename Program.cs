Console.Write("Masukkan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukkan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PENCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {subtotal}");
Console.WriteLine($"Biaya administrasi = {biayaAdministrasi}");
Console.WriteLine($"Total bayar = {totalBayar}");