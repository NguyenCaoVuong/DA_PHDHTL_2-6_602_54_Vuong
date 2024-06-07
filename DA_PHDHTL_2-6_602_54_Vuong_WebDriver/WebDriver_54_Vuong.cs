using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PHDHTL_2_6_602_54_Vuong_WebDriver
{
    public class WebDriver_54_Vuong
    {
        private ChromeDriverService chromeDriverService;
        private ChromeDriver driver;
        private bool isDriverInitialized = false;
        private bool skipvideo = false; // Kiểm tra video được skip hay chưa
        private bool mutevideo = false; // Kiểm tra video được skip hay chưa

        public WebDriver_54_Vuong()
        {
            // Khởi tạo ChromeDriverService để ẩn cửa sổ dòng lệnh
            chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
        }

        private void InitializeDriver()
        {
            // Khởi tạo Chrome driver chỉ một lần
            if (!isDriverInitialized)
            {
                // Khởi tạo Chrome driver
                driver = new ChromeDriver(chromeDriverService);
                isDriverInitialized = true;
            }
        }

        public void OpenYouTube()
        {
            InitializeDriver(); // Gọi hàm khởi tạo Chrome driver
            driver.Url = "https://www.youtube.com/"; // Mở URL Youtube
            driver.Manage().Window.Maximize(); //Phóng to trình duyệt chrome
            driver.Navigate();
        }

        public void SearchYouTube(string searchTerm)
        {
            if (driver == null)
            {
                MessageBox.Show("Vui lòng bắt đầu trình duyệt trước khi tìm kiếm.");
                return;
            }

            try
            {
                // Tìm đối tượng nút tìm kiếm trên trang web
                var searchIcon = driver.FindElement(By.Id("search-icon-legacy"));
                searchIcon.Click();

                // Tìm đối tượng ô tìm kiếm
                var searchBar = driver.FindElement(By.Name("search_query"));
                searchBar.Clear();
                searchBar.SendKeys(searchTerm);
                searchBar.Submit();
            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("Không tìm thấy phần tử:" +ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " +ex.Message);
            }
        }

        public void OpenFirstVideo()
        {
            // Kiểm tra xem trình điều khiển WebDriver đã được khởi tạo chưa
            if (driver == null)
            {
                // Nếu chưa được khởi tạo, hiển thị thông báo yêu cầu bắt đầu trình duyệt trước khi chọn video
                MessageBox.Show("Vui lòng bắt đầu trình duyệt trước khi chọn video.");
                return; // Kết thúc phương thức
            }

            try
            {
                // Tìm tất cả các phần tử trên trang web có class là "text-wrapper.style-scope.ytd-video-renderer"
                var searchResults = driver.FindElements(By.CssSelector(".text-wrapper.style-scope.ytd-video-renderer"));

                // Kiểm tra xem có kết quả video nào được tìm thấy hay không
                if (searchResults.Count > 0)
                {
                    // Nếu có, chọn phần tử video đầu tiên trong danh sách kết quả bằng cách nhấp vào nó
                    searchResults[0].Click();
                }
                else
                {
                    // Nếu không tìm thấy kết quả video nào, hiển thị thông báo cảnh báo cho người dùng
                    MessageBox.Show("Không tìm thấy kết quả video trong kết quả tìm kiếm.");
                }
            }
            catch (NoSuchElementException ex)
            {
                // Bắt ngoại lệ NoSuchElement khi không tìm thấy phần tử video và hiển thị thông báo cảnh báo tương ứng
                MessageBox.Show("Không tìm thấy phần tử video: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Bắt các ngoại lệ khác có thể xảy ra và hiển thị một thông báo lỗi chung cho người dùng
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        public void SkipVideo()
        {
            // Kiểm tra xem trình điều khiển WebDriver đã được khởi tạo chưa
            if (driver == null)
            {
                // Nếu chưa được khởi tạo, hiển thị thông báo yêu cầu bắt đầu trình duyệt
                MessageBox.Show("Vui lòng bắt đầu trình duyệt.");
                return; // Kết thúc phương thức
            }

            try
            {
                // Tìm phần tử trình phát video trên trang web
                var videoPlayer = driver.FindElement(By.CssSelector(".html5-video-player"));

                // Kiểm tra xem phần tử trình phát video có tồn tại không
                if (videoPlayer != null)
                {
                    // Nếu tồn tại, tìm và nhấp vào nút "skip" trên trình phát video (nếu có)
                    var skipButton = driver.FindElement(By.CssSelector(".ytp-next-button.ytp-button"));
                    if (skipButton != null)
                    {
                        skipButton.Click(); // Nhấp vào nút "skip"
                        skipvideo = !skipvideo; // Cập nhật trạng thái skip video
                    }
                    else
                    {
                        // Nếu không tìm thấy nút "skip" trên trình phát video, hiển thị thông báo cảnh báo
                        MessageBox.Show("Không tìm thấy nút skip trên trình phát video.");
                    }
                }
                else
                {
                    // Nếu không tìm thấy phần tử trình phát video, hiển thị thông báo cảnh báo
                    MessageBox.Show("Không tìm thấy trình phát video.");
                }
            }
            catch (NoSuchElementException ex)
            {
                // Bắt ngoại lệ NoSuchElement khi không tìm thấy phần tử video và hiển thị thông báo cảnh báo tương ứng
                MessageBox.Show("Không tìm thấy phần tử video: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Bắt các ngoại lệ khác có thể xảy ra và hiển thị một thông báo lỗi chung cho người dùng
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        public void MuteVideo()
        {
            // Kiểm tra xem trình điều khiển WebDriver đã được khởi tạo chưa
            if (driver == null)
            {
                // Nếu chưa được khởi tạo, hiển thị thông báo yêu cầu bắt đầu trình duyệt
                MessageBox.Show("Vui lòng bắt đầu trình duyệt.");
                return; // Kết thúc phương thức
            }

            try
            {
                // Tìm phần tử trình phát video trên trang web
                var videoPlayer = driver.FindElement(By.CssSelector(".html5-video-player"));

                // Kiểm tra xem phần tử trình phát video có tồn tại không
                if (videoPlayer != null)
                {
                    // Nếu tồn tại, tìm và nhấp vào nút "mute" trên trình phát video (nếu có)
                    var muteButton = driver.FindElement(By.CssSelector(".ytp-mute-button.ytp-button"));
                    if (muteButton != null)
                    {
                        muteButton.Click(); // Nhấp vào nút "mute"
                        mutevideo = !mutevideo; // Cập nhật trạng thái mute video
                    }
                    else
                    {
                        // Nếu không tìm thấy nút "mute" trên trình phát video, hiển thị thông báo cảnh báo
                        MessageBox.Show("Không tìm thấy nút mute trên trình phát video.");
                    }
                }
                else
                {
                    // Nếu không tìm thấy phần tử trình phát video, hiển thị thông báo cảnh báo
                    MessageBox.Show("Không tìm thấy trình phát video.");
                }
            }
            catch (NoSuchElementException ex)
            {
                // Bắt ngoại lệ NoSuchElement khi không tìm thấy phần tử video và hiển thị thông báo cảnh báo tương ứng
                MessageBox.Show("Không tìm thấy phần tử video: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Bắt các ngoại lệ khác có thể xảy ra và hiển thị một thông báo lỗi chung cho người dùng
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit(); // Đóng trình duyệt
                driver = null; // Gán driver về null để giải phóng bộ nhớ
                isDriverInitialized = false;
            }
        }
    }
}
